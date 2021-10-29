#version 330

out vec4 vecColor;

flat in float fPlotZ;

uniform vec4 uniVecMinPalette, uniVecMaxPalette;

float map(float value, float inMin, float inMax, float outMin, float outMax) {

	return outMin + (outMax - outMin) * (value - inMin) / (inMax - inMin);
}

void main() {

	//vecColor = vec4(1.0, fPlotZ, fPlotZ, 1.0);
	float mapped_red = map(fPlotZ, 0.0, 1.0, uniVecMinPalette.x, uniVecMaxPalette.x);
	float mapped_green = map(fPlotZ, 0.0, 1.0, uniVecMinPalette.y, uniVecMaxPalette.y);
	float mapped_blue = map(fPlotZ, 0.0, 1.0, uniVecMinPalette.z, uniVecMaxPalette.z);
	vecColor = vec4(mapped_red, mapped_green, mapped_blue, 1.0);
}
