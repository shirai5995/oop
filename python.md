# Pythonでの実装

```
class Metro:
    def __init__(self):
        self.name = "shirai"
        self.age = 80
    def salary(self):
        return self.age * 10000

mt = Metro()
print("NAME {}, AGE {}, SAL {}".format(mt.name, mt.age, mt.salary()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.name = n
        self.age = a
    def salary(self):
        return self.age * 10000

mt = Metro("aaaa", 80)
print("NAME {}, AGE {}, SAL {}".format(mt.name, mt.age, mt.salary()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.__name = n
        self.__age = a
    def getname(self):
        return self.__name
    def getage(self):
        return self.__age
    def salary(self):
        return self.__age * 10000

mt = Metro("aaaa", 80)
print("NAME {}, AGE {}, SAL {}".format(mt.getname(), mt.getage(), mt.salary()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.__name = n
        self.__age = a
    def getname(self):
        return self.__name
    def getage(self):
        return self.__age
    def salary(self):
        return self.__age * 10000
class SI(Metro):
    def bon(self):
        return super().salary() * 2

mt = SI()
print("NAME {}, AGE {}, SAL {}, BON {}".format(mt.getname(), 
                    mt.getage(), mt.salary(), mt.bon()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.__name = n
        self.__age = a
    def getname(self):
        return self.__name
    def getage(self):
        return self.__age
    def salary(self):
        return self.__age * 10000
class SI(Metro):
    def bon(self):
        return super().salary() * 2

mt = SI()
print("NAME {}, AGE {}, SAL {}, BON {}".format(mt.getname(), 
                    mt.getage(), mt.salary(), mt.bon()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.__name = n
        self.__age = a
    def getname(self):
        return self.__name
    def getage(self):
        return self.__age
    def salary(self):
        return self.__age * 10000
class SI(Metro):
    def __init__(self, name="shirai", age=49):
        super().__init__(name, age)
    def bon(self):
        return super().salary() * 2

mt = SI("yamada", 40)
print("NAME {}, AGE {}, SAL {}, BON {}".format(mt.getname(), 
                    mt.getage(), mt.salary(), mt.bon()))
```


```
class Metro:
    def __init__(self, n="shirai", a=49):
        self.__name = n
        self.__age = a
    def getname(self):
        return self.__name
    def getage(self):
        return self.__age
    def salary(self):
        return self.__age * 10000
class SI(Metro):
    def __init__(self, name="shirai", age=49):
        super().__init__(name, age)
    def bon(self):
        return super().salary() * 2
class OS(Metro):
    def salary(self):
        return super().getage() * 12000

mt = [ OS("yamada", 40), SI(), SI("sudo", 25) ]
for i in range(0,3):
    print("NAME {}, AGE {}, SAL {}".format(mt[i].getname(), 
                    mt[i].getage(), mt[i].salary()))
```
