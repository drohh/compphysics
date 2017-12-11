# This program tracks an object falling from a building of height h, with initial velocity = 0.

h = float(input("Enter the height (meters) of the building: "))
t = float(input("Enter the time interval (seconds): "))
g = 9.81 # acceleration due to gravity
s = g * t**2 / 2 # formula for how far the object falls
print("The y location of the object is {} meters".format(h-s))
