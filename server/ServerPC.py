import socket
from ocr_processing import *

def process_received_data():
    openCVTesserract()
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server_address = ('192.168.0.102', 12345)  # Replace 'your_pc_ip' with your PC's IP address
server_socket.bind(server_address)
server_socket.listen(1)

print("Server is listening...")
while True:
    connection, client_address = server_socket.accept()

    with open("received_image.jpg", "wb") as image_file:
        while True:
            data = connection.recv(1024)
            if not data:
                break
            image_file.write(data)

    connection.close()
    process_received_data()
    print("Image received and saved. Listening for additional input.")