forma_pg_lista = []
for i in range(1,37):
    forma_pg_lista.append((f"1 + {i}",f"1 + {i}"))
for i in range(1,37):
    forma_pg_lista.append((f"S/ Entrada + {i}",f"S/ Entrada + {i}"))

forma_pg_tuple = tuple(forma_pg_lista)

print(forma_pg_tuple)