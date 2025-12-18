n = int(input("Ile ocen chcesz wprowadzić? "))

suma = 0.0

for i in range(n):
    ocena = float(input("Podaj ocenę {i + 1}: "))
    suma += ocena

srednia = suma / n
print("Średnia ocen:", srednia)

if srednia >= 3.0:
    print("Uczeń zaliczył przedmiot.")
else:
    print("Uczeń nie zaliczył przedmiotu.")
