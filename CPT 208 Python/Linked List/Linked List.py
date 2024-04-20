class Node:
    def __init__(self, data):
        # Initialize a node with data and next pointer
        self.data = data  # Data value of the node
        self.next = None  # Pointer to the next node


class LinkedList:
    def __init__(self):
        # Initialize the linked list with a head pointer
        self.head = None  # Head pointer initially points to None

    def add_node(self, data):
        # Add a new node to the end of the linked list
        new_node = Node(data)  # Create a new node with given data
        if not self.head:
            # If the list is empty, set the new node as the head
            self.head = new_node
        else:
            # Traverse to the end of the list and append the new node
            current = self.head
            while current.next:
                current = current.next
            current.next = new_node

    def display(self):
        # Display all the node values in the linked list
        current = self.head
        while current:
            print(current.data, end=" -> ")  # Print data of current node
            current = current.next  # Move to the next node
        print("None")  # Indicate end of the list

    def length(self):
        # Calculate the length of the linked list
        count = 0  # Initialize count to zero
        current = self.head  # Start from the head node
        while current:
            count += 1  # Increment count for each node visited
            current = current.next  # Move to the next node
        return count  # Return the count


# Second Linked List with additional features
class OrderedLinkedList(LinkedList):
    def remove_node(self, data):
        # Remove a single node with specified data value from the list
        if not self.head:
            # If list is empty, return without doing anything
            return

        if self.head.data == data:
            # If the head node has the data, remove it by updating head
            self.head = self.head.next
            return

        prev = None  # Initialize previous node pointer
        current = self.head  # Start from the head node
        while current:
            if current.data == data:
                # If current node has the data, remove it by updating pointers
                prev.next = current.next
                return
            prev = current  # Move both pointers forward
            current = current.next

    def remove_nodes_with_value(self, data):
        # Remove all nodes with specified data value from the list
        while self.head and self.head.data == data:
            # Remove all consecutive nodes with data value at the beginning
            self.head = self.head.next

        prev = None  # Initialize previous node pointer
        current = self.head  # Start from the head node
        while current:
            if current.data == data:
                # If current node has the data, remove it by updating pointers
                prev.next = current.next
            else:
                prev = current  # Move previous pointer if data doesn't match
            current = current.next  # Move current pointer forward

    def add_node_in_order(self, data):
        # Add a node while maintaining ascending order of data values
        new_node = Node(data)  # Create a new node with given data

        if not self.head or self.head.data >= data:
            # If list is empty or new data is smaller than head, insert at head
            new_node.next = self.head
            self.head = new_node
            return

        current = self.head  # Start from the head node
        while current.next and current.next.data < data:
            # Find the correct position to insert the new node
            current = current.next

        new_node.next = current.next  # Insert the new node at correct position
        current.next = new_node

# Example usage:
if __name__ == "__main__":
    # First linked list
    ll = LinkedList()
    ll.add_node(5)
    ll.add_node(10)
    ll.add_node(15)

    print("First Linked List:")
    ll.display()
    print("Length:", ll.length())

    # Second linked list
    ol = OrderedLinkedList()
    ol.add_node_in_order(20)
    ol.add_node_in_order(10)
    ol.add_node_in_order(30)
    ol.add_node_in_order(5)

    print("\nSecond Linked List:")
    ol.display()

    print("\nAfter removing node with value 10:")
    ol.remove_node(10)
    ol.display()

    print("\nAfter removing all nodes with value 5:")
    ol.remove_nodes_with_value(5)
    ol.display()

    print("\nLength:", ol.length())

    print("\nAdding nodes in order to the second linked list:")
    ol.add_node_in_order(25)
    ol.add_node_in_order(35)
    ol.display()
    print("Length:", ol.length())
