/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    theme: {
        extend: {
            screens: {
                tablet: "768px",
                desktop: "1024px",

            }

            ,
            colors: {
                peach: {
                    primary: '#E7816B',
                    secondary: '#ffAD9B'
                },
                black: {
                    primary: '#1D1C1E',
                    secondary: '#333136'
                },
                white: {
                    primary: '#FFFFFF',
                    secondary: '#F1F3F5'
                },

            },

            fontFamily: {
                jost: ['Jost', 'sans-serif']
            }
        },
    },
    plugins: [],
}

