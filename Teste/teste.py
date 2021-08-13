# def codificar(s) :
 
#     i = 0

#     while i < len(s) - 1 :
 
#         count = 1
 
#         while s[i] == s[i + 1] :
           
#             i += 1
#             count += 1
            
#             if count == 9:
#                 break
#             if i + 1 == len(s):
#                 break
         
#         print(str(count) + str(s[i]), end = "")
                          
#         i += 1

# if __name__ == "__main__" :
 
#     codificar(input("Digite uma string para ser codificada: "))


import pandas as pd

df = pd.DataFrame(
{"Nome": ["Jonas", "Maria", "Alexandre"], "Idade": [18, 22, 36]}
)

print(df)


