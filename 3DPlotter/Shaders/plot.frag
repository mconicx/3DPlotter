#version 330

out vec4 vecColor;

flat in float fPlotZ;

void main() {

	vecColor = vec4(1.0, fPlotZ, fPlotZ, 1.0);
}
