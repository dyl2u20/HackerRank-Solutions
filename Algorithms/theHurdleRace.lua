function hurdleRace(k, height)
    table.sort(height)
    max=height[#height]
    local v = ((k>max) and 0 or max-k)
    return v
end

local fptr = io.open(os.getenv("OUTPUT_PATH"), "w")

local nk = {}
for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
    table.insert(nk, token)
end

local n = tonumber(nk[1]:match("^%s*(.-)%s*$"))

local k = tonumber(nk[2]:match("^%s*(.-)%s*$"))

local height = {}

for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
    table.insert(height, tonumber(token))
end

local result = hurdleRace(k, height)

fptr:write(result, "\n")

fptr:close()
