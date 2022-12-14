import telebot
import math

from requests import get
from random import Random
from telebot import types
from dataBase import *
from pyowm import OWM


# Создание и запуск бота
token = '5656785394:AAHFoIc1hJboEP3R7DTZF-xqU9NQ_J54LcE'
bot = telebot.TeleBot(token)
rand = Random()


# Получение погоды на завтра
owm = OWM('d5cac4e6f4c1cf038e73e9c68ac0b96a')
mgr = owm.weather_manager()
observation = mgr.weather_at_place('Moscow, tomorrow')
weather = observation.weather
temps = weather.temperature("celsius")
temp = temps['temp']


#Основные команды
@bot.message_handler(commands=['start'])
def send_welcome(message):
    markup = types.ReplyKeyboardMarkup(row_width= 3)
    startBtn = types.KeyboardButton('/start')
    helpBtn = types.KeyboardButton('/help')
    jokeBtn = types.KeyboardButton('/joke')
    weatherBtn = types.KeyboardButton('/weather')

    markup.row(startBtn)
    markup.row(jokeBtn, helpBtn)
    markup.row(weatherBtn)

    bot.send_message(message.chat.id, 'It works!', reply_markup=markup)

@bot.message_handler(commands=['help'])
def send_help(message):
    bot.send_message(message.chat.id, rand.choice(helpAnswers))

@bot.message_handler(commands=['joke'])
def send_joke(message):
    joke = rand.choice(jokes)
    bot.send_message(message.chat.id, joke)

@bot.message_handler(commands=['weather'])
def send_weather(message):
    bot.send_message(message.chat.id, f"Погода на завтра в Москве: {round(temp, 0)}")


#Доп функции
@bot.message_handler(commands=['stickers'])
def send_stickers(message):
    for stick in stikersId:
        bot.send_sticker(message.chat.id, stick)

@bot.message_handler(commands=['jokes'])
def send_jokes(message):
    for joke in jokes:
        bot.send_message(message.chat.id, joke)


#Реакции на текст и другие файлы
@bot.message_handler(content_types=['text'])
def send_reflect(message):
    message.text = message.text.lower()
    if (message.text.find('дел') != -1):
        bot.send_message(message.chat.id, rand.choice(howareuAnswers))
    elif (message.text.find('прив') != -1):
        bot.send_message(message.chat.id, rand.choice(welcomeAnswers))
    elif (message.text.find('погод') != -1):
        send_weather(message)
    elif (message.text.find('анекдот') != -1):
        bot.send_message(message.chat.id, rand.choice(jokes))
    else:
        bot.send_message(message.chat.id, rand.choice(understandAnswers))

@bot.message_handler(content_types=['audio', 'document', 'photo', 'sticker', 'voice',])
def send_stiker(message):
    sticker = rand.choice(stikersId)
    bot.send_sticker(message.chat.id, sticker)


#Запуск бота
bot.infinity_polling()
