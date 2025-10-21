


def main():
    #Weird() 
    #is_leap_year(1990)
    #Counter()
    #Students()
    #listComprehensions()
    mapOrnegi()
    
def Weird():
     n = int(input().strip())
     result="Not Weird"
     if (n%2==0) or (n>=6 and n<=20):
         result="Weird"
     print(result)
     

def is_leap_year(year):
    leap = False
    if year%4==0:
        if year%100==0:
            if year%400==0:
                leap=True
            else:
                leap=False  
        else:
            leap=True    
    print(leap)
def Counter():
    malcount=int(input("ayakkabı mikarı giriniz"))
    mallar=input("bedenleri giriniz").split()
    mustericount=int(input("Müşteri sayısı"))
    kazanc=0
    for i in range(mustericount):
        talep=input("müşteri talebini giriniz").split()
        for stok in mallar:
            if stok==talep[0]:
                kazanc=kazanc+int(talep[1])
                mallar.remove(stok)
                break
    print(kazanc)
    return 
def Students():
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
   # average = sum(student_marks[query_name]) / len(student_marks[query_name])
    total=0
    count=0
    for score in student_marks[query_name]:
        total=total+score
        count=count+1
    print("{:.2f}".format(total/count))
   # print("{:.2f}".format(avaraage))
def listComprehensions():
    x = int(input())
    y = int(input())
    z = int(input())
    n = int(input())
    result=[]
    for a in range(x+1):
        for b in range(y+1):
            for c in range(z+1):
                if a+b+c<=n:
                    result.append("[{0}, {1}, {2}]".format(a,b,c))
    print("["+",".join(result)+"]")
def mapOrnegi():
    n = int(input())
    arr =list( map(int, input().split()))
    forbiden= max(arr)
    maxi=0
    for i in arr:
        if maxi<i and i!=forbiden:
            maxi=i
    print(maxi)
main()