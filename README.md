# MRTranslate: Bridging Language Barriers in the Physical World Using a Mixed Reality Point-and-Translate System

![In this project, we contribute the design, implementation, and evaluation of MRTranslate, an assistive Mixed Reality (MR) prototype that enables seamless translations of real-world text.](/Figures/MRTranslate.PNG?raw=true "In this project, we contribute the design, implementation, and evaluation of MRTranslate, an assistive Mixed Reality (MR) prototype that enables seamless translations of real-world text.")

*Figure 1: In this project, we contribute the design, implementation, and evaluation of MRTranslate, an assistive Mixed Reality (MR) prototype that enables seamless translations of real-world text.*

ABSTRACT Language barriers pose significant challenges in our increasingly globalized world, hindering effective communication and access to information. Existing translation tools often disrupt the current activity flow and fail to provide seamless user experiences. In this project, we contribute the design, implementation, and evaluation of MRTranslate, an assistive Mixed Reality (MR) prototype that enables seamless translations of real-world text. We instructed 12 participants to translate items on a food menu using MRTranslate, which we compared to state-of-the-art translation apps, including Google Translate and Google Lens. Findings from our user study reveal that when utilising a fully functional implementation of MRTranslate, participants achieve success in up to 91.67% of their translations whilst also enjoying the visual translation of the unfamiliar text. Although the current translation apps were well perceived, the participants particularly appreciated the convenience of not having to grab a smartphone and manually input the text for translation when using MRTranslate. We believe that MRTranslate, along with the empirical insights we have gained, presents a valuable step towards a future where MR transforms language translation and holds the potential to assist individuals in various day-to-day experiences.


![The figure shows the experience pipeline of MRTranslate.](/Figures/overview_pipeline.png?raw=true "The figure shows the experience pipeline of MRTranslate.")

*Figure 2: Our pipeline consists of a) \emph{user input}, i.e., pointing to the text in the real world the user wants to translate, b) a \emph{server-client processing}, i.e., taking the user-generated image as input, applying optical character recognition to extract the text (\emph{``Pansoti in salsa di noci''}), and then translating the text using the Google Translate API (\emph{``Ravioli in walnut sauce''}), and c) \emph{output}, i.e., translating the real-world text and outputting it either visually or auditory on the user's MR glasses.

### Requirements
* Raspberry Pi 2 or higher (e.g., https://amzn.eu/d/3Qc0ftn)
* Raspberry Pi Camera Module 3 (e.g., https://amzn.eu/d/2vpq8pF)
* Mini Button Switch (e.g., https://amzn.eu/d/73zxLGq)
* Mixed Reality Headset (Meta Quest Pro or Meta Quest 3)
* The following libraries are required for the Python scripts: cv2, pytesseract, gTTS, deep_translator, picamera2, libcamera, playsound, time, socket, RPi.GPIO

Link to the paper for more details:  [AVI 2024 Paper, Link available later](https://dx.doi.org/TODO)



  
