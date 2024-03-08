# Import required packages
import cv2
import pytesseract
import time
import socket
import RPi.GPIO as GPIO
	
from picamera2 import Picamera2, Preview
from translate import *  
from libcamera import controls 
picam = Picamera2()

config = picam.create_preview_configuration(main={"size": (640, 320)})
picam.configure(config)
picam.set_controls({"AfMode": controls.AfModeEnum.Manual, "LensPosition": 10.0})

def button_callback(channel):
	print("button was pushed")
	#picam.start_preview(Preview.QTGL)
	picam.start()
	#picam.set_controls({"AfMode": controls.AfModeEnum.Continuous})

	time.sleep(1)
	picam.capture_file("testpicamera.jpg")

	client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	server_address = ("192.168.0.102", 12345)

	try:
		client_socket.connect(server_address)

		with open("testpicamera.jpg","rb") as image_file:
			while True:
				data = image_file.read(1024)
				if not data:
					break
				client_socket.sendall(data)

	except ConnectionRefusedError:
		print("Connection failed")

	finally:
		client_socket.close()

GPIO.setwarnings(False)
GPIO.setmode(GPIO.BOARD)
GPIO.setup(10, GPIO.IN, pull_up_down=GPIO.PUD_DOWN)

GPIO.add_event_detect(10,GPIO.RISING,callback=button_callback)

message = input ("Press key to quit.")
GPIO.cleanup()



	
	





