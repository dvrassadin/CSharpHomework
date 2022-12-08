//
//  functions.swift
//  Task19Swift
//
//  Created by Daniil Rassadin on 8/12/22.
//

import Foundation
/**
 Возвращает количество цифр в числе.
 */
func countOfNumbers (in number: Int) -> Int {
    var countOfNumbers = 0
    var mutableNumber = number

    if mutableNumber < 0 { mutableNumber = -mutableNumber }

    while mutableNumber > 0 {
        mutableNumber /= 10
        countOfNumbers += 1
    }
    return countOfNumbers
}
/**
 Возвращает true если число — палиндром и false если нет.
 */
func isPalindrome(_ number: Int) -> Bool {
    var isPalindrome = true
    var mutableNumber = number

    var i = Int(pow(Double(10), Double(countOfNumbers(in: number) - 1)))
    
    while i > 9 {
        if mutableNumber / i == mutableNumber % 10 {
            mutableNumber -= mutableNumber / i * i
            mutableNumber /= 10
            i /= 100
        } else {
            isPalindrome = false
            break
        }
    }
    return isPalindrome
}
