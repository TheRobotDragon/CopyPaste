import ui
import clipboard
import requests
import json



def receive(sender):
	'@type sender: ui.Button'
	label = sender.superview['textview1']
	url = 'https://api.myjson.com/bins/eg34t'
	myResponse = requests.get(url)
#	if(myResponse.ok)
	jdata = json.loads(myResponse.content)
	label.text = jdata['text']
	clipboard.set(label.text)

def send(sender):
	'@type sender: ui.Button'
	textView1 = sender.superview['textview1']
	textView1.text = clipboard.get()
	url = 'https://api.myjson.com/bins/eg34t'
	json = {'text':clipboard.get()}
	thisResponse = requests.put(url,json=json) 
		
v = ui.load_view()

if min(ui.get_screen_size()) >= 768:
	# iPad
	v.frame = (0, 0, 360, 400)
	v.present('sheet')
else:
	# iPhone
	v.frame = (0, 0, 360, 400)
	v.present('sheet')
	#v.present(orientations=['portrait
	#receive(v['button1'])
	#send(v['button1'])

