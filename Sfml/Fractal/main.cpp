#include <SFML\Graphics.hpp>

int main()
{
    sf::RenderWindow window(sf::VideoMode::getDesktopMode(), "Fractal", sf::Style::Fullscreen);
    while (window.isOpen())
    {
        sf::Event event;
        window.pollEvent(event);
        switch (event.type)
        {
        case sf::Event::Closed:
            window.close();
            break;
        case sf::Event::KeyPressed:
            if(event.key.code == sf::Keyboard::Escape)
                window.close();
            break;
        default:
            break;
        }

        sf::Shader shader;
        if(!shader.loadFromFile("fractal.frag", sf::Shader::Fragment))
            return 1;
        
    }
}