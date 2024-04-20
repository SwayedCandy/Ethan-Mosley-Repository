def binary_search(arr, target):
    # Initialize left and right pointers
    left = 0
    right = len(arr) - 1
    # Initialize probes counter
    probes = 0

    # Binary search algorithm
    while left <= right:
        # Increment probes counter
        probes += 1
        # Calculate mid index
        mid = (left + right) // 2
        # Check if target is found at mid
        if arr[mid] == target:
            return True, probes
        # If target is greater, search right half
        elif arr[mid] < target:
            left = mid + 1
        # If target is smaller, search left half
        else:
            right = mid - 1

    # If target not found, return False
    return False, probes


def main():
    # Ask user for array size
    array_size = int(input("Enter the array size: "))
    # Ask user for maximum value
    max_value = int(input("Enter the maximum value: "))

    # Create the array containing values from 1 to maximum
    arr = [i for i in range(1, max_value + 1)]

    # Ask user for the search value
    search_value = int(input("Enter the search value: "))

    # Perform binary search
    found, probes = binary_search(arr, search_value)

    # Respond to the user
    if found:
        print(f"The value {search_value} was located within the array.")
    else:
        print(f"The value {search_value} was not found within the array.")

    # Display number of probes needed
    print(f"Number of probes needed: {probes}")


if __name__ == "__main__":
    main()
