import math
import time
def PrimeNum1(n,m):
    for a in range(n,m+1):
        if a > 1:
            for i in range(2,int(math.sqrt(a))+ 1):##work fine as well
                if a % i == 0:
                    break
            else:
                 print(a)
    return True
def PrimeNum(m,n):
    for a in range(m,n+1):
        for i in range(2,a):
            if a%i==0:
                break
        else:
            print(a)
def sieveOfErosthen(m,num):
    prime=dict()
    for a in range(2,num+1):
        prime[a]=True
    for b in prime:
        factor=range(b,num+1,b)
        for c in factor:
             prime[c]= False
    for e in prime:
        if prime[e]==True:
            print(e)
            
t=int(input(''))
count=0
if t<=10:
    while count<t:
        entrie =input('')
        (m,n)=entrie.split()
        m=int(m)
        n=int(n)
        if m<n and n<=1000000000 and n-m<=100000:
            tiempo=time.time()
            sieveOfErosthen(m,n)
            
            print(time.time()-tiempo)

        count+=1
        
