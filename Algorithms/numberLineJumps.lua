function kangaroo(x1, v1, x2, v2)

        if v1>v2 then
            remainder = (x1-x2)%(v2-v1)
            if remainder == 0 then
                return "YES"
            end
         end
      return "NO"
end

local fptr = io.open(os.getenv("OUTPUT_PATH"), "w")

local x1V1X2V2 = {}
for token in string.gmatch(io.stdin:read("*l"), "[^%s]+") do
    table.insert(x1V1X2V2, token)
end

local x1 = tonumber(x1V1X2V2[1]:match("^%s*(.-)%s*$"))

local v1 = tonumber(x1V1X2V2[2]:match("^%s*(.-)%s*$"))

local x2 = tonumber(x1V1X2V2[3]:match("^%s*(.-)%s*$"))

local v2 = tonumber(x1V1X2V2[4]:match("^%s*(.-)%s*$"))

local result = kangaroo(x1, v1, x2, v2)

fptr:write(result, "\n")

fptr:close()
