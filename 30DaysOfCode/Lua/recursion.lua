local n = io.stdin:read("*n", "*l")
function factorial(x) if x == 0 then return 1 else return x * factorial(x - 1) end end
print(factorial(n)) 
