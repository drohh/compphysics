import math

G = 6.67 * pow(10, -11) # Gravitational constant; m^3 * kg^-1 * s^-2
M = 5.97 * pow(10, 24) # Mass of earth; kg 
R = 6371 * 10**3 # Radius of earth; km * 10^3 = m

def orbitAltitude(time):
	h = ( G*M*pow(time, 2) / (4 * math.pi**2) )**(1/3) - R
	return h

t = float(input("How many seconds do you want it to take for your object to orbit earth once? "))
print("The object must have an altitude of {} kilometers to orbit earth in {} seconds.".format(round(orbitAltitude(t)/1000,5), round(t,5)))
input()