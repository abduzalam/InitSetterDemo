# InitSetterDemo

Its a C# 9.0 Feature.

Mutable – Can change

Immutable – Cannot Change


Consider traditional way :

Member Class 

![image](https://user-images.githubusercontent.com/32676744/224680666-d1c9d7f8-d0f6-4dcf-9e4e-044ac6593c08.png)


Main Program

![image](https://user-images.githubusercontent.com/32676744/224680762-03d352f5-63e7-4ee3-a247-405c3ccd50c0.png)


Output

![image](https://user-images.githubusercontent.com/32676744/224680812-a5d2b157-318b-428d-a0d9-4830e3a49247.png)


Lets assume Id is Unique and cannot be changed once the object is Initialized.

In this case we can change the Id of memberObj as like below


Modified Code

![image](https://user-images.githubusercontent.com/32676744/224681369-1e114098-b3a7-4aea-8d23-6faef63f7064.png)


New Output

![image](https://user-images.githubusercontent.com/32676744/224681325-453be8d0-0e0a-4adc-a083-b3a4cc7da456.png)


So how to prevent this In traditional Way ? Using a constructor as shown below :

![image](https://user-images.githubusercontent.com/32676744/224686882-9e41df01-a03e-4d42-ab9e-960551d86c19.png)

### Note that we removed the set from Id property in above code

Main Program

![image](https://user-images.githubusercontent.com/32676744/224687063-9c91b4bc-4332-4e3b-b8d8-98bf8f07da8f.png)

Output 

![image](https://user-images.githubusercontent.com/32676744/224687205-baf601bc-96c0-4a4f-92db-671d366cccc6.png)

so now lets try to modify the id after printing the result

![image](https://user-images.githubusercontent.com/32676744/224687779-896ca901-c922-44db-abce-ddd22bb3b41c.png)

So this means Id is now **immutable** and once the object is initialized, it can' be changed 

# Now lets do the same using Init option

Modify the Member class as shown below


![image](https://user-images.githubusercontent.com/32676744/224689339-bfc7bb93-72f3-42a1-9aa5-3515c320c086.png)


### In above code, we have not added any constructor to initialize the Id parameter

Back to our main code

![image](https://user-images.githubusercontent.com/32676744/224689510-dbeb8827-f09b-48a8-b3b3-630ed1df6481.png)

See above, we can initialize the Id value using the above method..


Now Lets change our member class like below , here we changed set to Init for Name and Address

![image](https://user-images.githubusercontent.com/32676744/224689971-fa12c3d6-66ad-49ab-8617-661272811b9c.png)

In the main program , we are assigning only the Id value like below

![image](https://user-images.githubusercontent.com/32676744/224690131-d0851bc7-ddf6-4750-aee7-188ee46b2d50.png)


so later if we try to assign value to Name or Address, the will not work.

see the output 

![image](https://user-images.githubusercontent.com/32676744/224690298-e64b33ea-917b-4201-a2e3-51ea99480b5f.png)


only Id is having value, Name and Address are null values 


# So the benefit of using the Init is to avoid creating 100s of constructors if there is a use case like that










