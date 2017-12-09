pub fn Captcha(input: &str) -> u32 {
    let mut output = 0;

    for (index, character) in input.chars().enumerate() {
        let int: u32 = character.to_digit(10).unwrap();
        
        if index == input.len() - 1 {
            if character == input.chars().nth(0).unwrap() {
                output += int;
            }
            break;
        }

        if character == input.chars().nth(index + 1).unwrap() {
            output += int;
        }
    }

    return output;
}

pub fn CaptchaPtTwo(input: &str) -> u32 {
    let mut output = 0;
    let offset = input.len() / 2;

    for (index, character) in input.chars().enumerate() {
        let mut next_index = index + offset;

        if next_index >= input.len() {
            next_index = next_index - input.len()
        }

        if character == input.chars().nth(next_index).unwrap() {
            output += character.to_digit(10).unwrap();
        }
    }

    return output;
}