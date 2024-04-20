# palindrome_checker.py

from stack3 import Stack
from queue1 import Queue

def is_palindrome(input_str):
    # Create instances of the Stack and Queue classes
    stack_instance = Stack()
    queue_instance = Queue()

    # Process the input string to remove non-alphanumeric characters and convert to lowercase
    processed_str = ''.join(char.lower() for char in input_str if char.isalnum())

    # Push each character into the stack and queue
    for char in processed_str:
        stack_instance.push(char)
        queue_instance.enqueue(char)

    # Compare characters popped from the stack and dequeued from the queue
    while len(stack_instance._data) > 0 and len(queue_instance._data) > 0:
        if stack_instance.pop() != queue_instance.dequeue():
            return False

    # If the loop completes without returning False, it's a palindrome
    return True
