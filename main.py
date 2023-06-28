import random

print("Hellow wrold!")

sum = 0

i = 0
while i < 3:
    a = random.randint(1, 24)
    b = random.randint(1, 24)
    c = random.randint(1, 24)
    print(a, b ,c)

    x = int(input("Введите число: "))

    if x == a or x == b or x == c:
        sum = sum + 1

    i = i + 1

if sum >= 2:
    print("Вы выиграли!")
elif sum < 2:
    print("Вы проиграли!")