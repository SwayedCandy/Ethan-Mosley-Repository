class TreeNode:
    def __init__(self, key):
        self.left = None
        self.right = None
        self.val = key

def insert(root, key):
    if root is None:
        return TreeNode(key)
    else:
        if root.val < key:
            root.right = insert(root.right, key)
        else:
            root.left = insert(root.left, key)
    return root

def search(root, key):
    if root is None or root.val == key:
        return root
    if root.val < key:
        return search(root.right, key)
    return search(root.left, key)

def print_tree(root):
    if root:
        print_tree(root.left)
        print(root.val)
        print_tree(root.right)

# Example usage:
root = None
root = insert(root, 50)
insert(root, 30)
insert(root, 20)
insert(root, 40)
insert(root, 70)
insert(root, 60)
insert(root, 80)

print("Binary Search Tree in inorder traversal:")
print_tree(root)

# Example of search
print("\nSearching for 40:")
result = search(root, 40)
if result:
    print("Node found:", result.val)
else:
    print("Node not found")
