import firebase_admin
from firebase_admin import firestore
from firebase_admin import credentials


class FireStore:
    def __init__(self, keyPath):
        self.keyPath = keyPath
        pass

    def client(self):
        cred = credentials.Certificate(self.keyPath)
        app = firebase_admin.initialize_app(cred)
        db = firestore.client()
        return db
