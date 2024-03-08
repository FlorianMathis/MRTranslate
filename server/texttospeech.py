import os
import playsound
from gtts import gTTS

def texttospeech(OCRvalue):
    
  # Language in which you want to convert
  language = 'en'
    
  # Passing the text and language to the engine, 
  # here we have marked slow=False. Which tells 
  # the module that the converted audio should 
  # have a high speed
  if(len(OCRvalue)>0):
    myobj = gTTS(text=OCRvalue, lang=language, slow=False)
    myobj.save(<path where you want to store your file>)

