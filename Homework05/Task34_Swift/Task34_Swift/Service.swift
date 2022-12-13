//
//  Service.swift
//  Task34_Swift
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
 Возвращает количество чётных чисел в массиве.
 */
func countOfEvenNumber(in array: [Int]) -> Int {
    var count = 0
    for i in array {
        if i % 2 == 0 {
            count += 1
        }
    }
    return count
}
