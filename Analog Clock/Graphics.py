import turtle as t
import time

hourHand = t.Turtle()
minuteHand = t.Turtle()
secondHand = t.Turtle()
clock = t.Turtle()
times = t.Turtle()

hourHand.speed('fastest')
minuteHand.speed('fastest')
secondHand.speed('fastest')
clock.speed('fastest')
times.speed('fastest')

hourHand.hideturtle()
minuteHand.hideturtle()
secondHand.hideturtle()
clock.hideturtle()
times.hideturtle()

hourHand._delay(5)
minuteHand._delay(5)
secondHand._delay(5)
clock._delay(5)
times._delay(5)

HOUR_INCREMENT = 30
MINUTE_INCREMENT = 6
SECOND_INCREMENT = 6
HOURS = 12
MINUTES = 720
SECONDS = 43200
hourHandLength = 125
minuteHandLength = 200
secondHandLength = 300
startingDeg = 90
CLOCK_SIZE = 300

def relocateExec(obj, action, *args, **kwargs):
    obj.penup()
    action(*args, **kwargs)
    obj.pendown()


def drawClock():
    clock.width(3)
    clock.pencolor('black')
    relocateExec(clock, clock.goto, 0, -300)
    clock.circle(CLOCK_SIZE)

def writeTimes():
    hours = ['12', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11']
    for i in hours:
        distance = 300
        if i in ['12', '1', '10', '11']:
            distance = 250
        elif i in ['3', '9', '2', '10']:
            distance = 275
        elif i in ['4', '8']:
            distance = 290
        times.setheading(90 - (int(i) * 30))
        times.penup()
        times.goto(0, 0)
        times.forward(distance)
        relocateExec(times, times.write, i, align = 'center', font = ('arial', 24, 'normal'))



def drawHourHand(deg, color):
    hourHand.pencolor(color)
    hourHand.pensize(10)
    relocateExec(hourHand, hourHand.goto, 0, 0)
    hourHand.setheading(deg)
    hourHand.forward(hourHandLength)

def drawMinuteHand(deg, color):
    minuteHand.pensize(5)
    minuteHand.pencolor(color)
    relocateExec(minuteHand, minuteHand.goto, 0, 0)
    minuteHand.setheading(deg)
    minuteHand.forward(minuteHandLength)

def drawSecondHand(deg, color):
    secondHand.pensize(2)
    secondHand.pencolor(color)
    relocateExec(secondHand, secondHand.goto, 0, 0)
    secondHand.setheading(deg)
    secondHand.forward(secondHandLength)

def hourDegreeCalc():
    return startingDeg - int(CURRENT_TIME[:2]) * HOUR_INCREMENT

def minuteDegreeCalc():
    return startingDeg - int(CURRENT_TIME[3:5]) * MINUTE_INCREMENT

def secondDegreeCalc():
    return startingDeg - int(CURRENT_TIME[6:8]) * SECOND_INCREMENT

drawClock()
writeTimes()

while True:
    CURRENT_TIME = str(time.ctime()[11:19])
    drawHourHand(hourDegreeCalc(), 'black')
    drawMinuteHand(minuteDegreeCalc(), 'black')
    drawSecondHand(secondDegreeCalc(), 'black')

    if CURRENT_TIME[3:8] in '59:5859:59':
        hourHand.clear()
    elif CURRENT_TIME[6:8] in '5859':
        minuteHand.clear()
    time.sleep(.6)
    secondHand.clear()