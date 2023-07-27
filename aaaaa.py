import RPi.GPIO as GPIO
import serial
from time import sleep
import threading
import Adafruit_DHT

GPIO.setwarnings(False)
GPIO.setmode(GPIO.BCM)


#LDR
ldrpin = 24
GPIO.setup(ldrpin,GPIO.IN)

#PIR
pirpin = 4
GPIO.setup(pirpin,GPIO.IN)

#yagmur
yagmurpin = 27
GPIO.setup(yagmurpin,GPIO.IN)


#servo
servopin = 18
GPIO.setup(servopin,GPIO.OUT)
servo = GPIO.PWM(servopin,50)
servo.start(0)

#pervane
pervanepin = 23
GPIO.setup(pervanepin,GPIO.OUT)
GPIO.output(pervanepin,GPIO.HIGH)


#ampul
ampulin1 = 12
ampulin2 = 13
ampulen = 19
temp1=1
GPIO.setup(ampulin1,GPIO.OUT)
GPIO.setup(ampulin2,GPIO.OUT)
GPIO.setup(ampulen,GPIO.OUT)
GPIO.output(ampulin1,GPIO.LOW)
GPIO.output(ampulin2,GPIO.LOW)
ampul=GPIO.PWM(ampulen,1000)
ampul.start(25)

#buzzer
buzzer = 22
GPIO.setup(buzzer,GPIO.OUT)
GPIO.output(buzzer,GPIO.LOW)

ser = serial.Serial ("/dev/ttyS0", 9600)    #Open port with baud rate


def servoDondur(aci):
    return (float(aci) / 18.0 + 2)

def dataGonder():
    global pirdurum
    ldr = "ldr-"
    ldr += str(1 - GPIO.input(ldrpin))
    ldr += "\r\n"
    ser.write(ldr.encode())
    

    pir = "pir-"
    pir += str(GPIO.input(pirpin))
    pir += "\r\n"
    ser.write(pir.encode())
            
    
    yagmur = "yagmur-"
    yagmur += str(1 - GPIO.input(yagmurpin))
    yagmur += "\r\n"
    ser.write(yagmur.encode())
    
    try:
        humidity, temperature = Adafruit_DHT.read(Adafruit_DHT.DHT11, 17)
        sicaklik = "sicaklik-"
        sicaklik += str(temperature)
        sicaklik += "\r\n"
        ser.write(sicaklik.encode())
    except RuntimeError as error:     # Errors happen fairly often, DHT's are hard to read, just keep going
        print(error.args[0])
    
    print (ldr)
    print (pir)
    print (yagmur)
    print (sicaklik)
    dataTimer = threading.Timer(2.0, dataGonder)
    dataTimer.start()



while True:
    dataGonder()
    while True:
        rd = ser.read()              #read serial port
        if len(rd) == 0:
            break
        sleep(0.03)
        data_left = ser.inWaiting()             #check for remaining byte
        rd += ser.read(data_left)
        if(rd.strip() == b"reset"):
            servo.start(servoDondur(0))
            GPIO.output(ampulin1,GPIO.LOW)
            GPIO.output(buzzer,GPIO.LOW)
            GPIO.output(pervanepin,GPIO.HIGH)
        
        elif(rd.strip() == b"kapi90"):
            servo.start(servoDondur(90))
            
        elif(rd.strip() == b"kapi0"):
            servo.start(servoDondur(0))
            
        elif(rd.strip() == b"ampul0"):
            GPIO.output(ampulin1,GPIO.LOW)
            
        elif(rd.strip() == b"ampul33"):
            GPIO.output(ampulin1,GPIO.HIGH)
            ampul.ChangeDutyCycle(50)
            
        elif(rd.strip() == b"ampul66"):
            GPIO.output(ampulin1,GPIO.HIGH)
            ampul.ChangeDutyCycle(75)
            
        elif(rd.strip() == b"ampul100"):
            GPIO.output(ampulin1,GPIO.HIGH)
            ampul.ChangeDutyCycle(100)
            
        elif(rd.strip() == b"buzzer1"):
            GPIO.output(buzzer,GPIO.HIGH)
            
        elif(rd.strip() == b"buzzer0"):
            GPIO.output(buzzer,GPIO.LOW)
    
        elif(rd.strip() == b"fan0"):
            GPIO.output(pervanepin,GPIO.HIGH)
            
        elif(rd.strip() == b"fan1"):
            GPIO.output(pervanepin,GPIO.LOW)
            
        
            
        print (str(rd))                   #print received data
        ser.write(rd)                #transmit data serially