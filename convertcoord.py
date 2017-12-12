# This program converts coordinates to polar/cartesian. 
from math import cos, sin, sqrt, atan, thetarees

def ptoc(r, theta):
	x = r*cos(theta)
	y = r*sin(theta)
	return x,y
	
def ctop(x, y):
	r = sqrt(x**2 + y**2)
	theta = degrees(atan(y / x))
	return r,round(theta, 5)