import pandas as pd
import requests
from bs4 import BeautifulSoup
def one_page_list(sosok, page):
    url = "https://finance.naver.com/sise/sise_quant.nhn".format(sosok, page)
    
    res = requests.get(url)
    soup = BeautifulSoup(res.text, 'lxml')

    STOCK_NAME_LIST = []
    STOCK_PRICE_LIST = []

    for tr in soup.findAll('tr'):
        stockName = tr.findAll('a', attrs={'class', 'tltle'})
        if stockName is None or stockName == []:
            pass
        else:
            stockName = stockName[0].contents[-1]
            STOCK_NAME_LIST.append(stockName)

        stockPrice = tr.findAll('td', attrs={'class', 'number'})
        if stockPrice is None or stockPrice == []:
            pass
        else:
            stockPrice = stockPrice[0].contents[-1]
            stockPrice = stockPrice.replace(",","")
            STOCK_PRICE_LIST.append(stockPrice)
    STOCK_LIST = []

    for i in range(len(STOCK_NAME_LIST)):
        stockInfo = [STOCK_NAME_LIST[i], int(STOCK_PRICE_LIST[i])]
        STOCK_LIST.append(stockInfo)

    return pd.DataFrame(STOCK_LIST, columns=('종목명','현재가'))

df = one_page_list(1,1)

print("<현재 네이버 금융 국내 코스피 상위100 기업 목록>")

pd.set_option('display.max_rows', None)
print (df['종목명'])
print()
compname = input("주가를 검색할 기업이름을 입력하세요 : ")
print("%s 기업의 현재 주가 입니다." %compname)
print (df.loc[df['종목명'] == ("%s" %compname)])