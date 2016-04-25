import ptvsd
ptvsd.enable_attach("SomeSecret")

print("Test debugging")
x = -1
while x != 0:
    x = int(input("Set x:"))
    print(x)