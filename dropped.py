# This program tracks an object falling from a building of height h, with initial velocity = 0.
import math

# Calculate the time it takes for the object to hit the ground
h = float(input("Enter the height (meters) of the building: "))
g = 9.81 # acceleration due to gravity
timeToGround = math.sqrt(h / g * 2)
print("The object will hit the ground in {} seconds.".format(timeToGround))
input()

# Analysis of object at a particular time
'''
t = float(input("Enter the time interval (seconds): "))
s = g * t**2 / 2 # formula for how far the object falls
print("The y location of the object is {} meters".format(h-s))
'''
