//
//  Service.swift
//  Task36_Swift
//
//  Created by Daniil Rassadin on 13/12/22.
//

import Foundation

/**
 Возвращает массив с count количеством элементов со значениями от minValue до maxValue.
 */
func createArray(with count: UInt, minValue: Int, maxValue: Int) -> [Int] {
    var array: [Int] = []
    for _ in 1...count {
        array.append(Int.random(in: minValue...maxValue))
    }
    return array
}

/**
Возвращает сумму элементов массива с нечётными индексами.
 */
func sumOfOddIndexElement(in array: [Int]) -> Int? {
    guard array.count > 1 else {
    return nil }
    
    var sum = 0
    var i = 1
    while i < array.count {
        sum += array[i]
        i += 2
    }
    
    return sum
}
