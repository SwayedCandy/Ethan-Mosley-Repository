# main_script.py

from palindrome_checker import is_palindrome

# Prompt the user to enter a string
user_input = input("Enter a string: ")

# Test the palindrome checker with the user's input
result = is_palindrome(user_input)

# Print the result
if result:
    print(f"{user_input} is a palindrome.")
else:
    print(f"{user_input} is not a palindrome.")
