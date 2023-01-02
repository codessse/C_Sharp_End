import FireStore as fs
from pathlib import Path
from time import sleep
import numpy as np
from urllib import parse
from pprint import pprint
from opencc import OpenCC
from lxml import etree
import pandas as pd
import json
import re

firestore = fs.FireStore("Certificate JSON PATH")
db = firestore.client()

data_path = r".\FirestoreData.json"

with open(data_path, 'r', encoding='utf8') as j:
    contents = json.loads(j.read())

for i in contents:
    print(i['名字'])
    doc_ref = db.document('ark/{}'.format(i['名字'])).set(i)

