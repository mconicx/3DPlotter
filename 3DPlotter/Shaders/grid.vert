#version 330

layout(location = 0) in vec3 attrVertPos;

uniform mat4 uniMatP, uniMatMV;

flat out int iVertID;

void main() {

	gl_Position = uniMatP * uniMatMV * vec4(attrVertPos, 1.0);
	iVertID = gl_VertexID;
}
