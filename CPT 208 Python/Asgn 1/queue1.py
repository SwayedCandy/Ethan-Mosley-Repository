# queue1.py

# Define the Queue class
class Queue:
    # Initialize the queue with an empty list
    def __init__(self):
        self._data = []

    # Add data to the end of the queue
    def push(self, data):
        self._data.append(data)

    # Add data to the end of the queue (alternative spelling)
    def enqueue(self, data):
        self._data.append(data)

    # Remove and return the front element from the queue
    def dequeue(self):
        if len(self._data) >= 1:
            return self._data.pop(0)
        else:
            return "error"

    # Print the elements of the queue
    def look(self):
        print(self._data)

    # Return the front element of the queue without removing it
    def peek(self):
        return self._data[0]

# Create an instance of the Queue class
q = Queue()
# Push some elements onto the queue
q.push(10)
q.enqueue(20)
q.enqueue(30)
# Print the current state of the queue
q.look()
# Print the front element of the queue
print(q.peek())
# Dequeue an element from the queue
test = q.dequeue()
# Print the dequeued element
print(test)
# Print the current state of the queue
q.look()
