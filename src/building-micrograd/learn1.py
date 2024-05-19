from micrograd.engine import Value

if 1 == 1:
    print("foo")
       
a = Value(-4)
b = Value(2)
c = a + b
d = a * b + b**3
c += c + 1
c += 1 + c + (-a)
d += d * 2 + (b + a).relu()
d += 3 * d + (b - a).relu()
e = c - d
f = e**2
g = f / 2.0
g += 10.0 / f
print(f"{g.data:.4f}")
g.backward()
print(f"{a.grad:.4f}")
print(f"{b.grad:.4f}")
