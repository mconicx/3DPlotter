#version 330

layout(location = 1) in vec3 attrVertPos;

uniform mat4 uniMatP, uniMatMV;
uniform int uniIHeight;

flat out float fPlotZ;

float map(float value, float inMin, float inMax, float outMin, float outMax) {

	return outMin + (outMax - outMin) * (value - inMin) / (inMax - inMin);
}

void main() {

	vec3 pos = attrVertPos;
	pos.x += 0.5;
	pos.y += 0.5;

	gl_Position = uniMatP * uniMatMV * vec4(pos, 1.0);
	fPlotZ = map(pos.z, 0.5, uniIHeight, 0.0, 1.0);
}
