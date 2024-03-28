import math
def Input_height_width(choice):
    height = int(input("Please enter the height of the tower: "))
    width = int(input("Please enter the width of the tower: "))
    if choice==1:
        rectangular_tower(height,width)
    else:
        triangular_tower(height,width)
def rectangular_tower(height,width):
    if height < 2:
        print("Tower height must be greater than or equal to 2.")
        return

    if height == width:
        print("It's a square.")
        print("Area:", height * width)
    else:
        print("It's a rectangle.")
        print("Perimeter:", 2 * (height + width))
def Triangle_area(height,width):
    for i in range(1, width + 1, 2):
        if i == 1:
            p = 1
        elif i == width:
            p = 1
        elif i == 3:
            p = (height - 2) // (math.ceil(width / 2) - 2) + ((height - 2) % (math.ceil(width / 2) - 2))
        elif (height - 2) % (math.ceil(width / 2) - 2) == 0:
            p = (height - 2) // ((math.ceil(width / 2)) - 2)
        else:
            p = (height - 2) // ((math.ceil(width / 2)) - 2)
        print(((" " * int((width - i) / 2)) + ("*" * int(i) + "\n")) * (math.floor(p)), end="")
def triangular_tower(height,width):

    if height < 2:
        print("Tower height must be greater than or equal to 2.")
        return
    if width % 2 == 0 or width > height * 2:
        print("Cannot print the triangle.")
        return
    print("Please select an option:")
    print("1. Calculation of the perimeter of the triangle")
    print("2. Printing the triangle")
    option = int(input())
    if option == 1:
        side_length = math.sqrt((width / 2.0) ** 2 + height ** 2)
        perimeter = 2 * side_length + width
        print("Perimeter of the triangle:", perimeter)
    elif option == 2:
        Triangle_area(height, width)
    else:
        print("Invalid option.")

def main():
    while True:
        print("\nTower Options:")
        print("1. Rectangular Tower")
        print("2. Triangular Tower")
        print("3. Exit")
        choice = int(input("Please choose an option: "))
        if choice == 1:
            Input_height_width(1)
        elif choice == 2:
            Input_height_width(2)
        elif choice == 3:
            print("Exiting program...")
            break
        else:
            print("Invalid choice. Please choose again.")

main()