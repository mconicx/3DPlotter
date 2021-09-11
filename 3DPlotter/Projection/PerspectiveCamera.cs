using OpenTK;
using System;

namespace _3DPlotter.Projection
{
    class PerspectiveCamera
    {
		private float _angleX, _angleZ, _zoom;
		private float _fov = 90f, _aspect = 1;
		private Vector3 _vecTarget, _vecFront, _vecRight, _vecUp;

        public Matrix4 ProjectionMatrix { get; private set; }
        public Matrix4 ModelviewMatrix { get; private set; }

		public float FOV
		{
			get => _fov;
			set
			{
				_fov = value;
				_UpdateProjection();
			}
		}

		public float Aspect
		{
			get => _aspect;
			set
			{
				_aspect = value;
				_UpdateProjection();
			}
		}

		public float AngleZ
		{
			get => MathHelper.RadiansToDegrees(_angleZ); 
			set
            {
				_angleZ = MathHelper.Clamp(value, -89.9f, 89.9f);
				_angleZ = MathHelper.DegreesToRadians(_angleZ);
				_UpdateModelview();
            }
		}

		public float AngleX
		{
			get => MathHelper.RadiansToDegrees(_angleX);
			set
            {
				_angleX = value;
				if (_angleX < 0f)
					_angleX = 359.9f;
				else if (_angleX > 359.9f)
					_angleX = 0f;

				_angleX = MathHelper.DegreesToRadians(value);
				_UpdateModelview();
            }
		}

		public float Zoom
        {
			get => _zoom;
			set
            {
				_zoom = MathHelper.Clamp(value, 5f, 100f);
				_UpdateModelview();
            }
        }

		public Vector3 vecTarget
        {
			get => _vecTarget;
			set
            {
				_vecTarget = value;
				_UpdateModelview();
            }
        }

		private void _UpdateProjection()
        {
			ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(_fov), _aspect, .1f, 1024f);
        }

		private void _UpdateModelview()
		{
			_vecFront.X = (float)Math.Cos(_angleZ) * (float)Math.Cos(_angleX);
			_vecFront.Y = (float)Math.Cos(_angleZ) * (float)Math.Sin(_angleX);
			_vecFront.Z = (float)Math.Sin(_angleZ);
			_vecFront = Vector3.Normalize(_vecFront);

			_vecRight = Vector3.Normalize(Vector3.Cross(_vecFront, Vector3.UnitZ));
			_vecUp = Vector3.Normalize(Vector3.Cross(_vecRight, _vecFront));

			ModelviewMatrix = Matrix4.LookAt(_vecFront * _zoom + _vecTarget, _vecTarget, _vecUp);
		}
	}
}
