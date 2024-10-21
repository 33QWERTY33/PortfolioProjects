import datetime as dt

while True:
    print()
    try:
        start = dt.datetime.strptime(input("What date would you like to start with (MM/DD/YY) >> "), "%m/%d/%y")
    except ValueError:
        start = dt.datetime.now()
        
    try:
        add_amt = int(input("How many days do you want to add >>>>>>>>>>>>>>>>>>> "))
    except ValueError:
        add_amt = 2

    try:
        repetitions = int(input("How many times do you want to add that value >>>>>>> "))
    except ValueError:
        repetitions = 1

    days = []

    for i in range(repetitions):
        start = start - dt.timedelta(days=1)
        count = 0
        weekdays_passed = 0
        while True:
            count += 1
            if (start + dt.timedelta(days=count)).weekday() <= 4:
                weekdays_passed += 1
            if weekdays_passed == add_amt:
                break
        
        start = start + dt.timedelta(days=count)
        days.append(start)

    for day in days:
        day_repr = day.strftime("%m/%d/%Y")
        print(day_repr[:-4] + day_repr[-2:])