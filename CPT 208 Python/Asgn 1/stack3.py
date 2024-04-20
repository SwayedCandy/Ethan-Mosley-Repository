# stack3.py

# Define the Stack class
class Stack:
    # Initialize the stack with an empty list
    def __init__(self):
        self._data = []

    # Add data to the top of the stack
    def push(self, data):
        self._data.append(data)

    # Remove and return the top element from the stack
    def pop(self):
        if len(self._data) >= 1:
            return self._data.pop()
        else:
            return "error"

    # Return the top element of the stack without removing it
    def peek(self):
        return self._data[len(self._data) - 1]

    # Print the elements of the stack
    def look(self):
        print(self._data)

# Create an instance of the Stack class
stack = Stack()
# Push some elements onto the stack
stack.push(10)
stack.push(20)
# Print the current state of the stack
stack.look()
# Print the top element of the stack
print(stack.peek())
# Pop an element from the stack
test = stack.pop()
# Print the popped element
print(test)
