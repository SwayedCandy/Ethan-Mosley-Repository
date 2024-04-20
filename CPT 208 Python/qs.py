class struct:
    def __init__self(self):
        self._data = []
        
    def look(self):
        print (self._data)
        
    def size(self):
        return len(self._data)
    



class queue(struct):
    def push(self,data):
        self._data.append(data)
        
    def enque(self,data):
        self._data.append(data)
        
    def deque(self):
        if((len (self._data)) >= 1):
            return self._data.pop(0)
        else:
            return "error"
        
    def peek(self):
        return self._data[0]
    
    
class stack(struct):
    def push(self,data):
        self._data.append(data)
        
    def pop(self):
        if ((len(self._data)) >= 1):
            return self._data.pop()
        else:
            return "error"
        
    def peek(self):
        return self._data[len(self._data) - 1]
    
    
    
    
s = stack()
q = queue()

s.push(4)
q.enque(4)
s.push(3)
q.enque(3)
s.push(2)
q.enque(2)
s.look()
q.look()
s.peek()
q.peek()

s.pop()
q.deque()
s.look()
q.look()

print (q.size())
print (s.size())        