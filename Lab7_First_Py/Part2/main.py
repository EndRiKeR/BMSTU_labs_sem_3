import telebot

from random import Random
from telebot import types

token = '5656785394:AAHFoIc1hJboEP3R7DTZF-xqU9NQ_J54LcE'
bot = telebot.TeleBot(token)

jokes = ['''Студент на экзамене по немецкому языку.\nЭкзаминатор: Составьте прдложение не немецком языке: "Лягушка скачет по болоту". \n Студент: Айн момент! Дер лягушка по болоту дер шлеп, дер шлеп, дер шлеп!''',
'''Преподаватель на лекции:
Как вставить элемент в массив?
Здесь все как в жизни: сначала раздвигаешь, потом вставляешь.
Препод на семиаре:
Вы еще не раздвинули, а уже вставляете.
@Тассов
''',
'''    Идет по лесу грустный заяц. На встречу ему медведь.
Спрашивает - ты чего такой грустный?
Заяц отвечает - волк мне прохода не дает, издевается постоянно.
Медведь - следующий раз, когда волк к тебе полезет, ты спроси его - "где твоя панама?".
Заяц - хорошо!
    Встречает волк зайца в лесу и начинает его доставать.
Заяц спрашивает - волк, а где твоя панама?
Волк - нет у меня никакой панамы.
Тут медведь подходит сзади с канализационным люком, бьет волка со словами - "вот твоя панама".
Волк - в больнице, заяц доволен. Проходит время, выписался волк, снова начал гонять зайца.
Заяц вновь к медведю - что мне делать?
Медведь - как встретишь волка, спроси - где твои часы.
Идет заяц по лесу, его догоняет волк, начал приставать.
Заяц спрашивает - волк, а где твои часы?
Волк радостно показывая руку - да вот мои часы!
Тут медведь вылазит из засады со словами - а вот твоя панама!''',
'Если бы сторож зоопарка не любил подходить к клетке с парой уссурийских тигров и злорадно орать: "Ага!", то, возможно, животные могли бы размножаться и в неволе',
'''Казнь. Палач занес топор. Подсудимый поднимает голову и
спрашивает:
- Какой сегодня день?
- Понедельник.
- Ну, блин, и начинается неделька.''',
'''Босс знакомится с новым шофером:
- Как ваша фамилия ?
- Меня зовут Лёша ...
- Меня интересует ваша фамилия , потому , что я привык обращаться к шоферам по фамилии!
- Я думаю, что вам будет не удобно меня по фамилии называть...
- Меня не интересует, что ты думаешь !
- Моя фамилия - Вжопузаорехами...
- Поехали, Вжопузаорехами''',
'Штирлиц попал в глубокую яму и чудом из нее вылез. "Чудес не бывает", - подумал Штирлиц и на всякий случай залез обратно.']

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
    bot.send_message(message.chat.id, 'Бог поможет!')

@bot.message_handler(commands=['joke'])
def send_joke(message):
    rand = Random()
    joke = rand.choice(jokes)
    bot.send_message(message.chat.id, joke)

@bot.message_handler(content_types=['text'])
def send_reflect(message):
    message.text = message.text.lower()
    if (message.text.find('дел') != -1):
        bot.send_message(message.chat.id, "В целом все ок!")
    elif (message.text.find('прив') != -1):
        bot.send_message(message.chat.id, "Прив)")
    else:
        bot.send_message(message.chat.id, "Ничего не понял, но очень интересно.")

@bot.message_handler(content_types=['audio', 'document', 'photo', 'sticker', 'voice',])
def send_stiker(message):
    bot.send_message(message.chat.id, "Получил документ.")


bot.infinity_polling()

# TODO: Добавить разнообразные ответы на "Привет" и "Как дела?"
# TODO: Отвечать на фото, видео, аудио и картинки стикерами
# TODO: Добавить прогноз погоды
