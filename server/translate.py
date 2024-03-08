import os
from deep_translator import GoogleTranslator

def translateGoogle(OCRvalue):
    return GoogleTranslator(source="it", target="en").translate(OCRvalue)

