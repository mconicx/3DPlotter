#version 330

out vec4 vecColor;

flat in int iVertID;

void main() {

	if (iVertID == 1 || iVertID == 2)		vecColor = vec4(1.0, 0.0, 0.0, 1.0);
	else if (iVertID == 3 || iVertID == 4)	vecColor = vec4(0.0, 1.0, 0.0, 1.0);
	else if (iVertID == 5 || iVertID == 6)	vecColor = vec4(0.0, 0.0, 1.0, 1.0);
	else vecColor =							vec4(1.0);
}
