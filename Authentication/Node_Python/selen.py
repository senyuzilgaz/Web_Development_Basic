import sys
import time
from selenium import webdriver

username = sys.argv[1]
password = sys.argv[2]


url= "https://www.reddit.com/login/"

options = webdriver.ChromeOptions()
options.add_experimental_option('excludeSwitches', ['enable-logging'])
driver = webdriver.Chrome(options = options, executable_path="C:/Users/ilgaz/Desktop/chromedriver.exe")

driver.get(url)

driver.find_element_by_id("loginUsername").send_keys(username)
driver.find_element_by_id("loginPassword").send_keys(password)
driver.find_element_by_class_name("AnimatedForm__submitButton").click()
time.sleep(1.2)

error_message = driver.find_element_by_class_name("AnimatedForm__errorMessage")
print(error_message.is_displayed())

driver.close()


