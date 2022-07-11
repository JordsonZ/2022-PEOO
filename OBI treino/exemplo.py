# x = []
# for i in range(10):
#   if i == 0:
#     valor = int(input())
#     n = valor
#     x.insert(i,valor)
#   else:
#     n = n * 2
#     x.insert(i,n)
# for i in range(10):
#   print('N[{0}] = {1}'.format(i,x[i]))

s = input().split(' ')
n = int(s[0])
i = int(s[1])
f = int(s[2])

valores = input().split(' ')
copia = valores

contador = 0
for k in range(0, n-1):
  for j in range(k+1, n):
    total = int(valores[k]) + int(copia[j])
    if total >= i and total <= f: contador += 1
print(contador)
  