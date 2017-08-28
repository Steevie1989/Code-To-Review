def summation():
    t=int(input(''))
    count=0
    while count<t:
        m =int(input(''))
        array=[m]
        n=input('')
        array=n.split()
        sum=0
        sum1=0
        for a in array:
            for b in range(int(a)):
                sum1+=int(array[b])
                print(array[b],end=',')
               # print('arayNumbers', array[b],'=',sum, end='')
            print()
        print()
        for s in array:
            s = int(s) + 1
            for d in range(int(s)):
                print(array[s],end=',')  
        count+=1
summation()  
