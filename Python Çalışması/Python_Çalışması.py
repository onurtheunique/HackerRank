


def main():
    # Weird() 
    # is_leap_year(1990)
    Counter()


    
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
        talep=input("müştei talebini giriniz").split()
        for stok in mallar:
            if stok==talep[0]:
                kazanc=kazanc+int(talep[1])
                mallar.remove(stok)
                break
    print(kazanc)
    return 
main()