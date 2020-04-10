local n = io.stdin:read("*n", "*l")

local arr = {}

for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
    table.insert(arr, tonumber(token))
end

for i=1, #arr do io.write(arr[#arr + 1 - i] .. " ") end
