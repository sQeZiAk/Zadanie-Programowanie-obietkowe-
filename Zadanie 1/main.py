a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))
dzial = input("Wybierz działanie (+, -, *, /): ")

if dzial == "+":
    wynik = a + b
elif dzial == "-":
    wynik = a - b
elif dzial == "*":
    wynik = a * b
elif dzial == "/":
    if b == 0:
        print("Nie można dzielić przez zero.")
        exit()
    wynik = a / b
else:
    print("Nieznany operator.")
    exit()

print("Wynik:", wynik)