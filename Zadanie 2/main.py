kierunek = input("Wybierz kierunek konwersji (C -> F wpisz 'C', F -> C wpisz 'F'): ")

if kierunek() == "C":
    c = float(input("Podaj temperaturę w °C: "))
    f = c * 1.8 + 32
    print("Temperatura w °F:", f)
elif kierunek() == "F":
    f = float(input("Podaj temperaturę w °F: "))
    c = (f - 32) / 1.8
    print("Temperatura w °C:", c)
else:
    print("Nieznany kierunek konwersji.")