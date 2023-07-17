import React from 'react'

import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'

import NavButton from '../../../../components/NavButton/NavButton'
import { FaHome } from 'react-icons/fa'
import { FaSearch } from 'react-icons/fa'
import { FaLightbulb } from 'react-icons/fa'
import { FaRegListAlt } from 'react-icons/fa'
import { FaUser } from 'react-icons/fa'
import styles from './Sidebar.module.css'

export default function Sidebar() {
	const { theme } = useSelector(state => state.theme)

	return (
		<nav className={`${styles.sidebar} ${theme === 'dark' && styles.dark}`}>
			<ul>
				<li>
					<Link to='/patient'>
						<FaHome />
					</Link>
				</li>
				<li>
					<Link to='/patient/search-drug'>
						<FaSearch />
					</Link>
				</li>
				<li>
					<Link to='/patient/documentations'>
						<FaRegListAlt />
					</Link>
				</li>
				<li>
					<Link to='/patient/give-advice'>
						<FaLightbulb />
					</Link>
				</li>
			</ul>
		</nav>
	)
}
