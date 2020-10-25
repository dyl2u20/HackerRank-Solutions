SinglyLinkedListNode = {}

function SinglyLinkedListNode:new(nodedata)
    local node = {
        data = nodedata,
        next = nil
    }

    setmetatable(node, self)
    self.__index = self

    return node
end

SinglyLinkedList = {}

function SinglyLinkedList:new()
    local list = {
        head = nil,
        tail = nil
    }

    setmetatable(list, self)
    self.__index = self

    return list
end

function SinglyLinkedList:insertnode(nodedata)
    local node = SinglyLinkedListNode:new(nodedata)

    if self.head == nil then
        self.head = node
    else
        self.tail.next = node
    end

    self.tail = node
end

function printsinglylinkedlist(node, sep)
    while node ~= nil do
        io.stdout:write(node.data)

        node = node.next

        if node ~= nil then
            io.stdout:write(sep)
        end
    end
end

function reversePrint(lllist)
    if llist ~= nil then
        reversePrint(llist.next)
        print(llist.data)
    end

end

local tests = io.stdin:read("*n", "*l")

for testsitr = 1, tests do
    local llistcount = io.stdin:read("*n", "*l")
    local llist = SinglyLinkedList:new()

    for _ = 1, llistcount do
        local llistitem = io.stdin:read("*n", "*l")
        llist:insertnode(llistitem)
    end

    reversePrint(llist.head)
end
