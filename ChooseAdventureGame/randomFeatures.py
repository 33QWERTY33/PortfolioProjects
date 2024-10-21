import random as r

def flipCoin():
    return r.randint(1, 2)
# flipCoin returns a 1 or 2 for heads or tails
def rollDie():
    return r.randint(1, 6)
# roll Die returns 1-6 for each side of a die

# I would like to add a user defined chance function here
'''
def chance():
    if user chose outcomes a, b, c:
        chance of outcome = 75%
    elif user chose outcomes a, b:
        chance of outcome = 50%
    else:
        chance of outcome = 25%
'''